﻿using System;

namespace Decision.ViewModels.Messages
{
    public class InBoxViewModel
    {
        public Guid Id { get; set; }
        public bool IsSeen { get; set; }
        public string Subject { get; set; }
        public DateTime SentOn { get; set; }
        public string DisplayName { get; set; }
    }
}
