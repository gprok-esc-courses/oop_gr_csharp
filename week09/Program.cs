using ducks;

List<Duck> ducks = new List<Duck>();

Duck d = new RedheadDuck();
Duck r = new RubberDuck();
r.flyBehavior = new FlyAsDrone();

ducks.Add(new RedheadDuck());
ducks.Add(new RubberDuck());
ducks.Add(d);
ducks.Add(r);

d.flyBehavior = new FlyNoWay();

d.flyBehavior = new FlyWithWings();


foreach(Duck duck in ducks)
{
    duck.flyBehavior.fly();
}
