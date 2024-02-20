public class Swimming:Activity{

    private int _numberOfLap;


    public void setLap(int lap){
        _numberOfLap = lap;
    }
    public override double getDistance()
    {
         _distance= _numberOfLap * 50/1000;
         return _distance;
    }
    public override double getSpeed()
    {
        _speed = getDistance()/_mins;
        return _speed;
    }
    public override double getPace()
    {
        _pace = _mins / _distance;
        return _pace;
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_mins} min) Distance {getDistance()} miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile ";
    }
}