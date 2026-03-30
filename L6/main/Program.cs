static class Program
{
    static void Main()
    {
        IModel model = new TransportInfo.Model();
        TransportInfo.IView view = new View.ConsoleView(model);
        IPresenter presenter = new Presenter.Presenter(view, model);
        view.SetPresenter(presenter);
        presenter.Init();
        ((View.ConsoleView)view).Start();
    }
}

