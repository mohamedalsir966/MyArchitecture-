﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Helpers
{
     public enum Order { asc, desc }
    public class QueryStringParameters
    {
        private const int MaxPageSize = 50;
        private int _pageSize = 10;
        private const int MinPageNumber = 1;
        private int _PageNumber = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int PageNumber
        {
            get => _PageNumber;
            set => _PageNumber = (value < MinPageNumber) ? MinPageNumber : value;
        }
      
        public string Search { get; set; }
        public string OrderBy { get; set; }
        public Order? order { get; set; }
       

    }

}
