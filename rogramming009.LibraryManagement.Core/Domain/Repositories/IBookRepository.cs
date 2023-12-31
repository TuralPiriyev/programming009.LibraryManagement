﻿using programming009.LibraryManagement.Core.Domain.Entities;
using System.Collections.Generic;

namespace programming009.LibraryManagement.Core.Domain.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);

        Book Get(int id);
        List<Book> Get();
    }
}