using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;


namespace WpfApp.ViewModel;

public class MainViewModel : ViewModelBase
{


    public interface StateBase
    {
        void Change(Context context);
    }

    public class State1 : StateBase
    {
        public void Change(Context context)
        {
  
            FileInfo f = new FileInfo($"MyFoto/pda.png");
            context.uri = new Uri(f.FullName, UriKind.Relative);
            context.image.ImageSource = new BitmapImage(context.uri);
            context.MM.Pnl.Background = context.image;
            context.control.Pause();
        }
    }
    public class State2 : StateBase
    {
        public void Change(Context context)
        {
            FileInfo f = new FileInfo($"MyFoto/Rda.png");
            context.uri = new Uri(f.FullName, UriKind.Relative);
            context.image.ImageSource = new BitmapImage(context.uri);
            context.MM.Pnl.Background = context.image;
            context.control.Pause();
        }
    }
    public class State3 : StateBase
    {
        public void Change(Context context)
        {
            FileInfo f = new FileInfo($"MyFoto/Nda.png");
            context.uri = new Uri(f.FullName, UriKind.Relative);
            context.image.ImageSource = new BitmapImage(context.uri);
            context.MM.Pnl.Background = context.image;
            context.control.Pause();
        }
    }
    public class State4 : StateBase
    {
        public void Change(Context context)
        {
            FileInfo f = new FileInfo($"MyFoto/Dda.png");
            context.uri = new Uri(f.FullName, UriKind.Relative);
            context.image.ImageSource = new BitmapImage(context.uri);
            context.MM.Pnl.Background = context.image;
            context.control.Play();
        }
    }

    public MainWindow MM { get; set; }
    public class Context
    {
        public Uri uri { get; set; }
        public MainWindow MM { get; set; }
        public ImageBrush image { get; set; } = new ImageBrush();
        public ImageAnimationController control { get; set; }
        public Context(StateBase state, int num,MainWindow obj)
        {
            MM = obj;
            control = ImageBehavior.GetAnimationController(MM.Ims);
            State = state;
            Request();
        }
        public StateBase State { get; set; }
        public void Request() => State.Change(this);
        public void StartRuquset(StateBase stateBase)
        {
            State = stateBase;
            State.Change(this);
        }
    }



    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (sender is Slider sl)
        {
            Context context1 = new Context(new State1(), 0, MM);
            if (sl.Value == 3)
                context1.StartRuquset(new State1());
            else if (sl.Value == 2)
                context1.StartRuquset(new State2());
            else if (sl.Value == 1)
                context1.StartRuquset(new State3());
            else if (sl.Value == 0)
                context1.StartRuquset(new State4()); 

        }
    }


    public MainViewModel(MainWindow obj)
    {
        MM = obj;
        MM.Sliders.ValueChanged += Slider_ValueChanged;
    }



}
