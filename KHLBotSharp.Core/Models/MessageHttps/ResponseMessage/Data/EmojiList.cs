﻿using KHLBotSharp.Models.MessageHttps.ResponseMessage.Data.Abstract;
using KHLBotSharp.Models.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHLBotSharp.Models.MessageHttps.ResponseMessage.Data
{
    public class EmojiList : BaseData
    {
        [JsonProperty("items")]
        public IEnumerable<Emoji> Items { get; set; }
    }
}
