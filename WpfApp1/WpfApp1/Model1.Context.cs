﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ukrasehieEntities : DbContext
    {
        public ukrasehieEntities()
            : base("name=ukrasehieEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Единицы_измерения> Единицы_измерения { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Категории> Категории { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Продукты> Продукты { get; set; }
        public virtual DbSet<Производители> Производители { get; set; }
        public virtual DbSet<Пункты_выдачи> Пункты_выдачи { get; set; }
        public virtual DbSet<Роли_пользователя> Роли_пользователя { get; set; }
        public virtual DbSet<Составы_заказа> Составы_заказа { get; set; }
        public virtual DbSet<Статусы> Статусы { get; set; }
    }
}
