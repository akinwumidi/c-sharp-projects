public class Cycling:Activity{

   public override double getDistance()
    {
         return _distance;
    }
    public override double getSpeed()
    {
        _speed = (getDistance()/_mins) * 60;
        return _speed;
    }
    public override double getPace()
    {
        _pace = _mins / _distance;
        return _pace;
    }
    public override string GetSummary()
    {
        double speed = getSpeed();
        string formattedSpeed = speed.ToString("F1");
        return $"{_date} Cycling ({_mins} min)- Distance {getDistance()} miles, Speed {formattedSpeed} mph, Pace: {getPace()} min per mile ";
    }

}