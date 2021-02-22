﻿// <auto-generated />
using System;
using Chat.Server.Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chat.Server.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    partial class ChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Chat.Common.Entities.ChatMessage", b =>
                {
                    b.Property<int>("IdChatMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.HasKey("IdChatMessage");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("Chat.Common.Entities.ChatUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("IdUser");

                    b.ToTable("ChatUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
