﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.EventBroker
{
    public class EventBrokerMain
    {
        public static void Main()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<EventBroker>().SingleInstance();
            cb.RegisterType<FootballCoach>();
            cb.RegisterType<Ref>();
            cb.Register((c, p) => new FootballPlayer(c.Resolve<EventBroker>(), p.Named<string>("name")));

            using (var c = cb.Build())
            {
                var referee = c.Resolve<Ref>(); // order matters here!
                var coach = c.Resolve<FootballCoach>();
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));
                player1.Score();
                player1.Score();
                player1.Score(); // only 2 notifications
                player1.AssaultReferee();
                player2.Score();
            }
        }
    }
}
