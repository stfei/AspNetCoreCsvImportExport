using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AspNetCoreCsvImportExport.Model
{
    public class LocalizationRecord
    {
       [IgnoreDataMember]
        public long Id { get; set; }

        public string Key { get; set; }
        [Display(Name ="文本")]
        public string Text { get; set; }
        [Display(Name = "本地化")]
        public string LocalizationCulture { get; set; }
        public string ResourceKey { get; set; }
    }
}
