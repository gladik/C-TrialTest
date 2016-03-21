namespace ISDTrialTest.Events
{
    internal delegate void MyEventHandler();

    internal class FamilyAction
    {
        public event MyEventHandler Action;

        public void DoAction()
        {
            OnSomeEvent();
        }

        private void OnSomeEvent()
        {
            Action?.Invoke();
        }
    }
}
