﻿using System;
using System.Threading.Tasks;
using Omise.Models;

namespace Omise.Examples
{
    public abstract class Example
    {
        public const string OMISE_PKEY = ExampleInfo.OMISE_PKEY;
        public const string OMISE_SKEY = ExampleInfo.OMISE_SKEY;

        protected Client Client { get; private set; }

        public Example()
        {
            this.Client = new Client(OMISE_PKEY, OMISE_SKEY);
        }

        // actually creates a new token, named RetrieveToken() so merchant read
        // this as an example call to get token from cient-side.
        protected async Task<Token> RetrieveToken()
        {
            return await Client.Tokens.Create(new CreateTokenRequest
            {
                Name = "Somchai Prasert",
                Number = "4242424242424242",
                ExpirationMonth = DateTime.Now.Month,
                ExpirationYear = DateTime.Now.Year + 10,
            });
        }

        // Creates a new PaymentSource called RetrieveSourceInternetBanking, as sources can be created client-side (as well as server-side).
        protected async Task<PaymentSource> RetrieveSourceInternetBanking()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "thb",
                Type = OffsiteTypes.InternetBankingBAY,
                Flow = FlowTypes.Redirect
            });
        }

        // Creates a new PaymentSource called RetrieveSourceBillPayment, as sources can be created client-side (as well as server-side).
        protected async Task<PaymentSource> RetrieveSourceBillPayment()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "thb",
                Type = OffsiteTypes.BillPaymentTescoLotus,
                Flow = FlowTypes.Offline
            });
        }

        // Creates a new PaymentSource called RetrieveSourceRabbitLinepay, as sources can be created client-side (as well as server-side).
        protected async Task<PaymentSource> RetrieveSourceRabbitLinepay()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "thb",
                Type = OffsiteTypes.RabbitLinepay,
                Flow = FlowTypes.Redirect
            });
        }

        public async Task<PaymentSource> RetrieveSourceTrueMoney()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "thb",
                Type = OffsiteTypes.TrueMoney,
                PhoneNumber = "0812345678"
            });
        }

        // Creates a new PaymentSource called RetrieveSourceFpx, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceFpx()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "myr",
                Type = OffsiteTypes.Fpx,
                Email = "example@omise.co",
                Bank = "cimb"
            });
        }

        // Creates a new PaymentSource called RetrieveSourceAlipayCN, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceAlipayCN()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.AlipayCN,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceAlipayHK, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceAlipayHK()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.AlipayHK,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceDANA, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceDANA()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.DANA,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceGCash, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceGCash()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.GCash,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceKakaoPay, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceKakaoPay()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.KakaoPay,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceTouchNGo, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceTouchNGo()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.TouchNGo,
                PlatformType = PlatformTypes.Web,
                Email = "example@omise.co",
            });
        }

        // Creates a new PaymentSource called RetrieveSourceOCBCPAO, as sources can be created client-side (as well as server-side).
        public async Task<PaymentSource> RetrieveSourceOCBCPAO()
        {
            return await Client.Sources.Create(new CreatePaymentSourceRequest
            {
                Amount = 2000,
                Currency = "sgd",
                Type = OffsiteTypes.MobileBankingOCBCPAO,
                PlatformType = PlatformTypes.iOS,
            });
        }
    }
}
