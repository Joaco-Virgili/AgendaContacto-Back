﻿using AgendaApi.Entities;
using AgendaApi.Models;
using AgendaApi.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Services.Interfaces
{
    public interface IContactService
    {
        void Create(CreateAndUpdateContact dto, int loggedUserId);
        void Delete(int id);
        List<Contact> GetAllByUser(int id);
        void Update(CreateAndUpdateContact dto);
    }
}