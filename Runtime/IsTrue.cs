namespace Labster.TruthHelper
{
    public static class BooleanExtension
    {
        public static bool IsTrue(this bool expression)
        {
            return expression;
        }

        public static bool IsFalse(this bool expression)
        {
            return !expression.IsTrue();
        }
    }
}