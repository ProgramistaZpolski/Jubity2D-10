using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace particleproject
{
    class Particle
    {
        private Color ParticleColor = Color.Red;
        private TimeSpan LiveTime = new TimeSpan(0,0,0,3);
        private DateTime? BirthTime;
        private PointF _Location;
        public PointF Location { get { return _Location; } set { _Location = value; } }
        private PointF _Velocity;
        public PointF Velocity { get { return _Velocity; } set { _Velocity = value; } }
        public static Random rg = new Random();
        public static PointF RandomVector(float speed)
        {
            float rangle = (float)((rg.NextDouble() * (Math.PI*2)));

            speed *= (float)rg.NextDouble();


            return new PointF((float)Math.Cos(rangle) * speed, (float)Math.Sin(rangle) * speed);







        }

        public Particle(PointF Location, float Speed):this(Location,RandomVector(Speed))
        {



        }

        public Particle(PointF Location, PointF Velocity)
        {
            _Location = Location;
            _Velocity = Velocity; 


        }


        public bool PerformFrame(ProgramState pst)
        {
            if(BirthTime==null) BirthTime = DateTime.Now;

            _Location = new PointF(_Location.X+_Velocity.X,_Location.Y+_Velocity.Y);
            _Velocity = new PointF(_Velocity.X*0.99f,_Velocity.Y*0.99f);


            return DateTime.Now - BirthTime > LiveTime;

        }
        public void Draw(Graphics g)
        {

            Color usecolor = ParticleColor;

            double mslivetime = (DateTime.Now - BirthTime).Value.TotalMilliseconds;
            double lifetime = LiveTime.TotalMilliseconds;

            double percentlife = mslivetime/lifetime;

            int Alphause = 255 - (int)(percentlife * 255);


            usecolor = Color.FromArgb(Alphause, ParticleColor);
            


            g.FillRectangle(new SolidBrush(usecolor), Location.X - 2, Location.Y - 2, 4, 4);

        }



    }
}
