﻿// <auto-generated />
using System;
using MAVN.Service.PartnersPayments.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.PartnersPayments.MsSqlRepositories.Migrations
{
    [DbContext(typeof(PartnersPaymentsContext))]
    [Migration("20200701113015_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("partners_payments")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.PartnersPayments.MsSqlRepositories.Entities.PartnerPaymentEntity", b =>
                {
                    b.Property<string>("PaymentRequestId")
                        .HasColumnName("payment_request_id")
                        .HasColumnType("text");

                    b.Property<string>("Currency")
                        .HasColumnName("currency")
                        .HasColumnType("text");

                    b.Property<DateTime>("CustomerActionExpirationTimestamp")
                        .HasColumnName("customer_action_expiration_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<decimal>("FiatAmount")
                        .HasColumnName("fiat_amount")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("FiatAmountPaidByCustomer")
                        .HasColumnName("fiat_amount_paid_by_customer")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastUpdatedTimestamp")
                        .HasColumnName("last_updated_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LocationId")
                        .HasColumnName("location_id")
                        .HasColumnType("text");

                    b.Property<string>("PartnerId")
                        .IsRequired()
                        .HasColumnName("partner_id")
                        .HasColumnType("text");

                    b.Property<string>("PartnerMessageId")
                        .HasColumnName("partner_message_id")
                        .HasColumnType("text");

                    b.Property<string>("PosId")
                        .HasColumnName("pos_id")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnName("status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TokensAmount")
                        .IsRequired()
                        .HasColumnName("tokens_amount")
                        .HasColumnType("text");

                    b.Property<string>("TokensAmountPaidByCustomer")
                        .HasColumnName("tokens_amount_paid_by_customer")
                        .HasColumnType("text");

                    b.Property<DateTime?>("TokensBurnTimestamp")
                        .HasColumnName("tokens_burn_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("TokensReserveTimestamp")
                        .HasColumnName("tokens_reserve_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TokensToFiatConversionRate")
                        .IsRequired()
                        .HasColumnName("tokens_to_fiat_conversion_rate")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalBillAmount")
                        .HasColumnName("total_bill_amount")
                        .HasColumnType("numeric");

                    b.HasKey("PaymentRequestId");

                    b.HasIndex("CustomerId");

                    b.ToTable("partners_payments");
                });

            modelBuilder.Entity("MAVN.Service.PartnersPayments.MsSqlRepositories.Entities.PaymentRequestBlockchainEntity", b =>
                {
                    b.Property<string>("PaymentRequestId")
                        .HasColumnName("payment_request_id")
                        .HasColumnType("text");

                    b.Property<string>("LastOperationId")
                        .IsRequired()
                        .HasColumnName("last_operation_id")
                        .HasColumnType("text");

                    b.HasKey("PaymentRequestId");

                    b.HasIndex("LastOperationId");

                    b.ToTable("payment_request_blockchain_data");
                });
#pragma warning restore 612, 618
        }
    }
}
