﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Decision.ViewModels.Messages;

namespace Decision.ServiceLayer.Interfaces.PrivateMessage
{
    public interface IMessageService
    {
        /// <summary>
        /// درج پیغام جدید به همراه موضوع
        /// </summary>
        /// <param name="viewModel"></param>
        void Create(AddConversationViewModel viewModel);
        /// <summary>
        /// ارسال پیغام 
        /// </summary>
        /// <param name="viewModel"></param>
        void Create(AddMessageViewModel viewModel);
        /// <summary>
        /// واکشی لیست پیغام های دریافتی
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<InBoxViewModel>> GetInBox(int page);
        /// <summary>
        /// واکشی لیست پیغام های ارسالی
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<OutBoxViewModel>> GetOutBox(int page);
        /// <summary>
        /// واکشی لیست پیغام های یک گفتگو
        /// </summary>
        /// <param name="conversationId"></param>
        /// <returns></returns>
        Task<MessageListViewModel> GetMessages(Guid conversationId);
        Task<bool> CheckAccess(Guid conversationId);
        Task DeleteAsync(Guid value);
        long NewMessgesCount();
    }
}