using Microsoft.AspNetCore.Components;

namespace YourAppNamespace.Pages
{
    public partial class Calculator : ComponentBase
    {
        protected double Number1 { get; set; }
        protected double Number2 { get; set; }
        protected string Result { get; set; } = string.Empty;

        protected void Add()
        {
            Result = (Number1 + Number2).ToString();
        }

        protected void Subtract()
        {
            Result = (Number1 - Number2).ToString();
        }

        protected void Multiply()
        {
            Result = (Number1 * Number2).ToString();
        }

        protected void Divide()
        {
            if (Number2 == 0)
            {
                Result = "Cannot divide by zero";
            }
            else
            {
                Result = (Number1 / Number2).ToString();
            }
        }
    }
}
