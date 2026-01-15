namespace DesignPatternPractice.DesignPatternArchitecturePattern
{
    
    /// <summary>
    /// Customer
    /// </summary>
    public class NormalCustomer : ICustomer
    {
        public NormalCustomer(IRating rating) { 
            
            this.Rating = rating.GetRatingScore(this); // Association example: using IRating interface to get rating score
            // connection between class NormalCustomer to interface IRating is very thin.
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Rating : give discount based on rating (cibil score)
        /// </summary>
        public decimal Rating { get; set; } 

        public decimal CalculateDiscount()
        {
            if (IsValidAmount()) 
            {

                return 0;
            }

            return 0;
        }

        /// <summary>
        /// private accessor to validate amount <- Encapsulation example
        /// </summary>
        /// <returns></returns>
        private bool IsValidAmount()
        {
            if(Amount > 0)
            {
                return true;
            }
            return false;
        }
    }


    /// <summary>
    /// StudentCustomer
    /// </summary>
    public class StudentCustomer : ICustomer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// InstitutionName : give discount based on institution name
        /// </summary>
        public string InstitutionName { get; set; } 
        public decimal CalculateDiscount()
        {
            if (IsValidAmount())
            {
                return 0;
            }
            return 0;
        }
        /// <summary>
        /// private accessor to validate amount <- Encapsulation example
        /// </summary>
        /// <returns></returns>
        private bool IsValidAmount()
        {
            if (Amount > 0)
            {
                return true;
            }
            return false;
        }
    }


    /// <summary>
    /// PremiumCustomer
    /// </summary>
    public class PremiumCustomer : ICustomer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// MembershipYears : give discount based on membership years
        /// </summary>
        public int MembershipYears { get; set; } 
        public decimal CalculateDiscount()
        {
            if (IsValidAmount())
            {
                return 0;
            }
            return 0;
        }
        /// <summary>
        /// private accessor to validate amount <- Encapsulation example
        /// </summary>
        /// <returns></returns>
        private bool IsValidAmount()
        {
            if (Amount > 0)
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// Product
    /// </summary>
    public class Product : IProduct
    {
        public string ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    /// <summary>
    /// Discount
    /// </summary>
    public class Discount : IDiscount
    {
        public decimal GetDiscountedPrice(ICustomer customer, IProduct product)
        {
            throw new NotImplementedException();
        }
    }

}
