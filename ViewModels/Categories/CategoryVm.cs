﻿using System;

namespace Backend.ViewModels.Categories
{
    public class CategoryVm
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public DateTime CreateAt { set; get; }
        public DateTime UpdateAt { set; get; }
    }
}