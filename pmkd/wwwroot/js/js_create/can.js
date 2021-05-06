function calculateFilterExpression(rowData) {
    return [getSystemId, "=", "BL1160000001"]
}
function getSystemId(rowData) {
    return rowData.SystemId;
}
var port, textEncoder, writableStreamClosed, writer;
async function connectSerial() {
    try {
        // Prompt user to select any serial port.
        port = await navigator.serial.requestPort();
        await port.open({ baudRate: 9600 });
        listenToPort();

        textEncoder = new TextEncoderStream();
        writableStreamClosed = textEncoder.readable.pipeTo(port.writable);
        alert("connect successful")
        writer = textEncoder.writable.getWriter();
    } catch {
        alert("Serial Connection Failed");
    }
}
async function sendSerialLine() {
    dataToSend = document.getElementById("lineToSend").value;
    appendToTerminal(dataToSend);
    await writer.write(dataToSend);
    var data = document.getElementById("lineToSend");
    data.value = "";
}
async function listenToPort() {
    const textDecoder = new TextDecoderStream();
    const readableStreamClosed = port.readable.pipeTo(textDecoder.writable);
    const reader = textDecoder.readable.getReader();

    // Listen to data coming from the serial device.
    while (true) {
        const { value, done } = await reader.read();
        if (done) {
            // Allow the serial port to be closed later.
            //reader.releaseLock();
            break;
        }
        // value is a string.
        appendToTerminal(value);
    }
}
const serialResultsDiv = document.getElementById("serialResults");

async function appendToTerminal(newStuff) {
    serialResultsDiv.value = newStuff;
}

document.getElementById("lineToSend").addEventListener("keyup", async function (event) {
    if (event.keyCode === 13) {
        sendSerialLine();
    }
})

