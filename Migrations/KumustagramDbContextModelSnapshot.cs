﻿// <auto-generated />
using System;
using Kumustagram_API.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kumustagram_API.Migrations
{
    [DbContext(typeof(KumustagramDbContext))]
    partial class KumustagramDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Kumustagram_API.Models.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ContentId");

                    b.HasIndex("UserId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("Kumustagram_API.Models.ContentComment", b =>
                {
                    b.Property<int>("ContentCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentStr")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ContentCommentId");

                    b.HasIndex("ContentId");

                    b.HasIndex("UserId");

                    b.ToTable("ContentComments");
                });

            modelBuilder.Entity("Kumustagram_API.Models.ContentLike", b =>
                {
                    b.Property<int>("ContentLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ContentLikeId");

                    b.HasIndex("ContentId");

                    b.HasIndex("UserId");

                    b.ToTable("ContentLikes");
                });

            modelBuilder.Entity("Kumustagram_API.Models.Follower", b =>
                {
                    b.Property<int>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FollowedUserId")
                        .HasColumnType("int");

                    b.Property<int>("FollowerUserId")
                        .HasColumnType("int");

                    b.HasKey("FollowerId");

                    b.HasIndex("FollowedUserId");

                    b.HasIndex("FollowerUserId");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("Kumustagram_API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("ResetPasswordExpire")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ResetPasswordToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Kumustagram_API.Models.Content", b =>
                {
                    b.HasOne("Kumustagram_API.Models.User", "User")
                        .WithMany("Contents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kumustagram_API.Models.ContentComment", b =>
                {
                    b.HasOne("Kumustagram_API.Models.Content", "Content")
                        .WithMany("ContentComments")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumustagram_API.Models.User", "User")
                        .WithMany("CommentedContents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kumustagram_API.Models.ContentLike", b =>
                {
                    b.HasOne("Kumustagram_API.Models.Content", "Content")
                        .WithMany("Likes")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumustagram_API.Models.User", "User")
                        .WithMany("LikedContents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kumustagram_API.Models.Follower", b =>
                {
                    b.HasOne("Kumustagram_API.Models.User", "FollowedUser")
                        .WithMany("FollowedUsers")
                        .HasForeignKey("FollowedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumustagram_API.Models.User", "FollowerUser")
                        .WithMany("FollowerUsers")
                        .HasForeignKey("FollowerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FollowedUser");

                    b.Navigation("FollowerUser");
                });

            modelBuilder.Entity("Kumustagram_API.Models.Content", b =>
                {
                    b.Navigation("ContentComments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Kumustagram_API.Models.User", b =>
                {
                    b.Navigation("CommentedContents");

                    b.Navigation("Contents");

                    b.Navigation("FollowedUsers");

                    b.Navigation("FollowerUsers");

                    b.Navigation("LikedContents");
                });
#pragma warning restore 612, 618
        }
    }
}
