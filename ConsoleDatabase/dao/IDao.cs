﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDatabase.dao
{
    interface IDao<T>
    {
        List<T> list();
        T find(int id);
        bool add(T item);
        bool update(T item);
        bool delete(int id);
    }
}
