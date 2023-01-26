﻿using System;

namespace BitPay.Exceptions
{

    public class PayoutRecipientNotificationException : PayoutRecipientException
    {
        private const string BitPayCode = "BITPAY-PAYOUT-RECIPIENT-NOTIFICATION";
        private const string BitPayMessage = "Failed to send payout recipient notification.";

        public PayoutRecipientNotificationException() : base(BitPayCode, BitPayMessage)
        {
        }

        public PayoutRecipientNotificationException(Exception ex, string apiCode = "000000") : base(BitPayCode, BitPayMessage, ex)
        {
            ApiCode = apiCode;
        }
    }
}
