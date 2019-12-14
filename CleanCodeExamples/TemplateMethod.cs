using System;

namespace CleanCodeExamples
{
    public class TemplateMethod : BakedGoodBase
    {
        protected override void CutIntoSlices()
        {
            throw new NotImplementedException();
        }

        protected override void AddToppings()
        {
            throw new NotImplementedException();
        }

        protected override void PrepareCrust()
        {
            throw new NotImplementedException();
        }

        protected override void Bake()
        {
            throw new NotImplementedException();
        }
    }
}
