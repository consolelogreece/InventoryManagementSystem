﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IMSLibrary
{
    public class ProductModel
    {
        /// <summary>
        /// Unique identifier of product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Product name, i.e. dress
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product description, I.e. pink, floral, size 12 dress.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product category, examples: "clothing", "makeup" etc..
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Date the user listed the item.
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Link to product, if listed on a site like ebay...
        /// </summary>
        public string ProductURL { get; set; }

        public int IntialStock { get; set; }

        public List<StockTransaction> StockTransactions { get; set; }

        /// <summary>
        /// Product status, examples: "At auctuon", "listed on ebay" etc...
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Path to image of product on users system.
        /// </summary>
        public string ImagePath { get; set; }
    }
}
