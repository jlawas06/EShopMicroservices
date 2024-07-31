﻿namespace Catalog.API.Exceptions;

public class ProductNotFoundException : Exception
{

    public ProductNotFoundException() : base("Product was not found.")
    {
    }
}
