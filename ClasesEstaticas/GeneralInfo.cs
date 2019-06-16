namespace ClasesEstaticas
{
    /*
     * An static class is useful when we need to represent something that
     * do not belong to a particular instance. I.E: General Information.
     * And we want to encapsulate all this related info in the same place.
     *
     * Static classes cannot be instantiated.
     * Static classes can only have static methods.
     * Static methods must be called on the class itself, not on the instances of the class.
     */
    public static class GeneralInfo
    {
        public static string CompanyName()
        {
            return "Super OOO Inc";
        }

        public static int YearOfCreation()
        {
            return 2007;
        }

        public static string Address()
        {
            return "1202 5th Avenue. NY - USA";
        }
        
    }
}