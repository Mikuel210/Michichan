using Timer = System.Windows.Forms.Timer;

namespace Michichan;

public partial class Michichan : Form
{
    private TimeSpan _countdownSpan;
    private TimeSpan _countdown;
    
    private Timer _timer = new();
    private DateTime _startTime;

    private bool _holding;
    private bool _running;
    
    public Michichan()
    {
        InitializeComponent();
        InitializeCountdown(TimeSpan.FromSeconds(-20));
    }

    private void timer_Tick(object? sender, EventArgs e) => UpdateCountdown();

    private void UpdateCountdown()
    {
        if (!_running)
        {
            label1.Text = "T--:--";
            label2.Text = "000";
            return;
        }
        
        var elapsed = DateTime.Now - _startTime;
        _countdown = _countdownSpan.Add(elapsed);
            
        TimeSpan displayTime = TimeSpan.FromTicks(Math.Abs(_countdown.Ticks));
            
        if (_countdown != displayTime)
            displayTime = displayTime.Add(TimeSpan.FromSeconds(1));
            
        string prefix = _countdown == displayTime ? "T+" : "T-";
            
        label1.Text = $"{prefix}{displayTime.Minutes:D2}:{displayTime.Seconds:D2}";
        label2.Text = $"{displayTime.Milliseconds:D3}";
    }

    private void InitializeCountdown(TimeSpan span)
    {
        _countdownSpan = span;
        _startTime = DateTime.Now;
        
        _timer.Interval = 10;   
        _timer.Start();

        _timer.Tick += timer_Tick;
        _holding = false;
        _running = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!_holding)
        {
            _holding = true;
            _timer.Stop();
        }
        else
        {
            _holding = false;
            _countdownSpan = _countdown;
            _startTime = DateTime.Now;
            _timer.Start();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        _timer.Stop();
        _running = false;
        UpdateCountdown();
    }
}