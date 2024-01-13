﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WPR.Migrations
{
    [DbContext(typeof(WPRDbContext))]
    [Migration("20240112163052_InitialCreate4")]
    partial class InitialCreate4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("WPR.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoesResearchID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpecialistID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("DoesResearchID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("SpecialistID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("WPR.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("TrackingID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WebsiteURL")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("WPR.Disability", b =>
                {
                    b.Property<int>("DisabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<int>("DisabilityTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DisabilityId");

                    b.HasIndex("DisabilityTypeId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Disabilitys");
                });

            modelBuilder.Entity("WPR.DisabilityType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DisabilityTypes");
                });

            modelBuilder.Entity("WPR.DoesResearch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InformationTrackingScript")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ResearchID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TempId")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ChatId")
                        .IsUnique();

                    b.HasIndex("ResearchID");

                    b.HasIndex("SpecialistId");

                    b.ToTable("DoesResearches");
                });

            modelBuilder.Entity("WPR.Guardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int>("SpecialistID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("WPR.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<int?>("SpecialistID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WPR.OnlineAssignmentResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoesResearchID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OnlineAssignmentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DoesResearchID");

                    b.HasIndex("OnlineAssignmentID");

                    b.ToTable("OnlineAssignmentResults");
                });

            modelBuilder.Entity("WPR.OurChat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DoesResearchInt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("User1ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("User2ID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("User1ID");

                    b.HasIndex("User2ID");

                    b.ToTable("OurChats");
                });

            modelBuilder.Entity("WPR.OurChatMessage", b =>
                {
                    b.Property<int>("OurChatMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OurChatID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderUserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.HasKey("OurChatMessageId");

                    b.HasIndex("Id");

                    b.HasIndex("OurChatID");

                    b.ToTable("OurChatMessages");
                });

            modelBuilder.Entity("WPR.OurUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OurUsers");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("WPR.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InterviewId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionnaireId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("InterviewId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WPR.Research", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<bool>("English")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reward")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CompanyId");

                    b.ToTable("Researches");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("WPR.Employee", b =>
                {
                    b.HasBaseType("WPR.OurUser");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WPR.Specialist", b =>
                {
                    b.HasBaseType("WPR.OurUser");

                    b.Property<bool>("ApproachCommercialParties")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisabilityNote")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<int>("GuardianID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MessagePreference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ToolsUsing")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TrackingID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasIndex("GuardianID")
                        .IsUnique();

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("Specialists");
                });

            modelBuilder.Entity("WPR.Interview", b =>
                {
                    b.HasBaseType("WPR.Research");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("WPR.OnlineAssignment", b =>
                {
                    b.HasBaseType("WPR.Research");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.ToTable("OnlineAssignments");
                });

            modelBuilder.Entity("WPR.Questionnaire", b =>
                {
                    b.HasBaseType("WPR.Research");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("WPR.Answer", b =>
                {
                    b.HasOne("WPR.DoesResearch", "DoesResearch")
                        .WithMany("Answers")
                        .HasForeignKey("DoesResearchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Specialist", "Specialist")
                        .WithMany()
                        .HasForeignKey("SpecialistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoesResearch");

                    b.Navigation("Question");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("WPR.Disability", b =>
                {
                    b.HasOne("WPR.DisabilityType", "DisabilityType")
                        .WithMany("disabilities")
                        .HasForeignKey("DisabilityTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WPR.Specialist", "Specialist")
                        .WithMany("Disabilities")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("DisabilityType");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("WPR.DoesResearch", b =>
                {
                    b.HasOne("WPR.OurChat", "chat")
                        .WithOne("DoesResearch")
                        .HasForeignKey("WPR.DoesResearch", "ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Research", "research")
                        .WithMany("doesResearches")
                        .HasForeignKey("ResearchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Specialist", "specialist")
                        .WithMany("doesResearches")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("chat");

                    b.Navigation("research");

                    b.Navigation("specialist");
                });

            modelBuilder.Entity("WPR.Location", b =>
                {
                    b.HasOne("WPR.Company", "Company")
                        .WithOne("Location")
                        .HasForeignKey("WPR.Location", "CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WPR.OnlineAssignmentResult", b =>
                {
                    b.HasOne("WPR.DoesResearch", "doesResearch")
                        .WithMany("OnlineAssignmentResults")
                        .HasForeignKey("DoesResearchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.OnlineAssignment", "OnlineAssignment")
                        .WithMany("OnlineAssignmentResults")
                        .HasForeignKey("OnlineAssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OnlineAssignment");

                    b.Navigation("doesResearch");
                });

            modelBuilder.Entity("WPR.OurChat", b =>
                {
                    b.HasOne("WPR.OurUser", "User1")
                        .WithMany("Chats")
                        .HasForeignKey("User1ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("WPR.OurUser", "User2")
                        .WithMany("Chats2")
                        .HasForeignKey("User2ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("WPR.OurChatMessage", b =>
                {
                    b.HasOne("WPR.OurUser", "Sender")
                        .WithMany("ChatMessages")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("WPR.OurChat", "ourChat")
                        .WithMany("Messages")
                        .HasForeignKey("OurChatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");

                    b.Navigation("ourChat");
                });

            modelBuilder.Entity("WPR.Question", b =>
                {
                    b.HasOne("WPR.Interview", "Interview")
                        .WithMany("Questions")
                        .HasForeignKey("InterviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Questionnaire", "Questionnaire")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interview");

                    b.Navigation("Questionnaire");
                });

            modelBuilder.Entity("WPR.Research", b =>
                {
                    b.HasOne("WPR.Company", "Company")
                        .WithMany("Researches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WPR.Employee", b =>
                {
                    b.HasOne("WPR.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("WPR.OurUser", null)
                        .WithOne()
                        .HasForeignKey("WPR.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WPR.Specialist", b =>
                {
                    b.HasOne("WPR.Guardian", "Guardian")
                        .WithOne("specialist")
                        .HasForeignKey("WPR.Specialist", "GuardianID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("WPR.OurUser", null)
                        .WithOne()
                        .HasForeignKey("WPR.Specialist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPR.Location", "Location")
                        .WithOne("specialist")
                        .HasForeignKey("WPR.Specialist", "LocationId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Guardian");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("WPR.Interview", b =>
                {
                    b.HasOne("WPR.Research", null)
                        .WithOne()
                        .HasForeignKey("WPR.Interview", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPR.OnlineAssignment", b =>
                {
                    b.HasOne("WPR.Research", null)
                        .WithOne()
                        .HasForeignKey("WPR.OnlineAssignment", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPR.Questionnaire", b =>
                {
                    b.HasOne("WPR.Research", null)
                        .WithOne()
                        .HasForeignKey("WPR.Questionnaire", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPR.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Location")
                        .IsRequired();

                    b.Navigation("Researches");
                });

            modelBuilder.Entity("WPR.DisabilityType", b =>
                {
                    b.Navigation("disabilities");
                });

            modelBuilder.Entity("WPR.DoesResearch", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("OnlineAssignmentResults");
                });

            modelBuilder.Entity("WPR.Guardian", b =>
                {
                    b.Navigation("specialist")
                        .IsRequired();
                });

            modelBuilder.Entity("WPR.Location", b =>
                {
                    b.Navigation("specialist");
                });

            modelBuilder.Entity("WPR.OurChat", b =>
                {
                    b.Navigation("DoesResearch");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WPR.OurUser", b =>
                {
                    b.Navigation("ChatMessages");

                    b.Navigation("Chats");

                    b.Navigation("Chats2");
                });

            modelBuilder.Entity("WPR.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("WPR.Research", b =>
                {
                    b.Navigation("doesResearches");
                });

            modelBuilder.Entity("WPR.Specialist", b =>
                {
                    b.Navigation("Disabilities");

                    b.Navigation("doesResearches");
                });

            modelBuilder.Entity("WPR.Interview", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("WPR.OnlineAssignment", b =>
                {
                    b.Navigation("OnlineAssignmentResults");
                });

            modelBuilder.Entity("WPR.Questionnaire", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
