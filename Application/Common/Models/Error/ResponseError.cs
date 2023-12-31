﻿using System.Collections.Generic;

namespace Application.Common.Models.Error
{
    public class ResponseError
    {
        public string Message { get; set; }
        public IEnumerable<ResponseErrorItem> Errors { get; set; }
    }
}
