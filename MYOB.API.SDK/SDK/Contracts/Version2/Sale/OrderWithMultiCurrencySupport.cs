﻿namespace MYOB.AccountRight.SDK.Contracts.Version2.Sale
{
    /// <summary>
    /// Descibes a subclassed <see cref="OrderWithLines{TOrderLine}"/> that has multi-currency support
    /// </summary>
    /// <typeparam name="TOrderLine"></typeparam>
    public abstract class OrderWithMultiCurrencySupport<TOrderLine> : OrderWithLines<TOrderLine>
        where TOrderLine : OrderLine
    {
        /// <summary>
        /// Sum of all tax exclusive foreign currency line amounts applicable to the sale invoice.
        /// </summary>
        public decimal? SubtotalForeign { get; set; }

        /// <summary>
        /// Tax freight foreign currency amount applicable to the sale order.
        /// </summary>
        /// <remarks>
        /// Only supported by Item or Service orders.
        /// </remarks>
        public decimal? FreightForeign { get; set; }

        /// <summary>
        /// Total of all foreign currency tax amounts applicable to the sale invoice.
        /// </summary>
        public decimal? TotalTaxForeign { get; set; }

        /// <summary>
        /// Total foreign currency amount of the sale invoice.
        /// </summary>
        public decimal? TotalAmountForeign { get; set; }

        /// <summary>
        /// The foreign currency amount paid to date.
        /// </summary>
        public decimal? AppliedToDateForeign { get; set; }

        /// <summary>
        /// The foreign currency balance due amount.
        /// </summary>
        public decimal? BalanceDueAmountForeign { get; set; }
    }
}