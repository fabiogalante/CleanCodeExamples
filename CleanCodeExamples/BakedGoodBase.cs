namespace CleanCodeExamples
{
    public abstract class BakedGoodBase
    {
        public void MakeBakeGood()
        {
            PrepareCrust();
            AddToppings();
            Bake();
            CutIntoSlices();
        }

        protected abstract void CutIntoSlices();

        protected abstract void AddToppings();

        protected abstract void PrepareCrust();

        protected abstract void Bake();


    }
}
