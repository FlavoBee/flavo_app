namespace Flavo
{
    public abstract class BaseScreenView : BaseView, IScreenView
    {
        public abstract void Open();

        public abstract void Close();
    }
}
