namespace DesignPatternPractice.DesignPatternArchitecturePattern
{
    public class Abstraction
    {
    }

    /// <summary>
    /// ICustomer
    /// </summary>
    public interface ICustomer 
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Amount { get; set; }

        public decimal CalculateDiscount();
    }

    /// <summary>
    /// IProduct
    /// </summary>    
    public interface IProduct
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    /// <summary>
    /// IDiscount
    /// </summary>
    public interface IDiscount
    {
        public decimal GetDiscountedPrice(ICustomer customer, IProduct product);
    }


    /// <summary>
    /// IRating
    /// </summary>
    public interface IRating
    {
        decimal score { get; set; }

        decimal GetRatingScore(ICustomer customer);
    }

    /***
     * Default Access Modifier in C#
     * Summary Table
     * ****************************************
        Context	             Default Access Modifier
        Top-level class	     internal (Top-level types class, interface, struct, enum    
            Nested class	 private
        Top-level interface	 internal
        Interface members	 public
        Class fields	     private
        Class methods	     private
        Class properties	 private    
     ****/


    /*************************
     * 
     * **************
     * Note:
     * 1. Abstraction: Interfaces are used to define abstract types that specify a contract without implementation details.
     * 2. Encapsulation: Interfaces help encapsulate behavior by exposing only the methods and properties defined in the interface, hiding the implementation details.
     * 
     * 🧠 Comparison Table
        Relationship	Type	Ownership	Lifecycle Dependency
Inheritance	IS-A	N/A	Child depends on Parent
Association	USES-A	❌ None	Independent
Aggregation	HAS-A	⚠️ Weak	Independent
Composition	HAS-A	✅ Strong	Dependent
     * 
     ********************************************/


}
