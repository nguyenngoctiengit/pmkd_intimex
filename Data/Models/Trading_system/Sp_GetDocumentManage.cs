using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetDocumentManage
    {
        [Key]
        public long DocId { get; set; }
        public string StyleCode { get; set; }
        public DateTime DocDate { get; set; }
        public string NumberSign { get; set; }
        public string Contents { get; set; }
        public string DocLevelName { get; set; }
        public string UserSend { get; set; }
        public DateTime DateReceive { get; set; }
        public int FeedBackNum { get; set; }
        public int StatusProcess { get; set; }
        public int NumberArchives { get; set; }
        public int IsProcessReady { get; set; }
        public DateTime DateProcess { get; set; }
        public DateTime DateCome { get; set; }
        public string NumberCome { get; set; }
        public int DocLever { get; set; }
        public int NumberOfPage { get; set; }
        public long DocPlaceId { get; set; }
        public string Singer { get; set; }
        public string Note { get; set; }
        public long DocTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }
        public long DocStyleId { get; set; }
        public string StyleName { get; set; }
        public string DocPlaceName { get; set; }
        public long DocProcessId { get; set; }
        public string UserName { get; set; }
        public int FeedBackNotCheckNum { get; set; }
        public string Command { get; set; }
        public long FeedBackId { get; set; }
    }
}
