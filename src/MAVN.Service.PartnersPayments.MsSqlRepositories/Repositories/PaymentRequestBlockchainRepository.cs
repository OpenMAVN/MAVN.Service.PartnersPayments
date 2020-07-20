﻿using System.Threading.Tasks;
using MAVN.Persistence.PostgreSQL.Legacy;
using MAVN.Service.PartnersPayments.Domain.Models;
using MAVN.Service.PartnersPayments.Domain.Repositories;
using MAVN.Service.PartnersPayments.MsSqlRepositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace MAVN.Service.PartnersPayments.MsSqlRepositories.Repositories
{
    public class PaymentRequestBlockchainRepository : IPaymentRequestBlockchainRepository
    {
        private readonly PostgreSQLContextFactory<PartnersPaymentsContext> _contextFactory;

        public PaymentRequestBlockchainRepository(PostgreSQLContextFactory<PartnersPaymentsContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task UpsertAsync(string paymentRequestId, string operationId)
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var entity = await context.PaymentRequestBlockchainData.FindAsync(paymentRequestId);

                if (entity == null)
                {
                    entity = PaymentRequestBlockchainEntity.Create(paymentRequestId, operationId);
                    context.PaymentRequestBlockchainData.Add(entity);
                }
                else
                {
                    entity.LastOperationId = operationId;
                }

                await context.SaveChangesAsync();
            }
        }

        public async Task<IPaymentRequestBlockchainData> GetByOperationIdAsync(string operationId)
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var result =
                    await context.PaymentRequestBlockchainData.FirstOrDefaultAsync(
                        x => x.LastOperationId == operationId);

                return result;
            }
        }
    }
}
