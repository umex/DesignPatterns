﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.Builder.Builder;
using DesignPatterns.Builder.BuilderInheritance;
using DesignPatterns.Builder.FacetedBuilder;
using DesignPatterns.Builder.FunctionalBuilder;
using DesignPatterns.Builder.StepwiseBuilder;
using DesignPatterns.Command.CompositeCommand;
using DesignPatterns.Factory.AbstractFactory;
using DesignPatterns.Factory.ObjectTrackingAndBulkReplacement;
using DesignPatterns.Factory.PointExample;
using DesignPatterns.Mediator.EventBroker;
using DesignPatterns.Mediator.MediatR;
using DesignPatterns.Observer.BidricetionalObserver;
using DesignPatterns.Observer.SpecialInterfaces;
using DesignPatterns.Prototype.CopyConstructors;
using DesignPatterns.Prototype.CopyThroughSerialization;
using DesignPatterns.Prototype.ICloneableIsBad;
using DesignPatterns.Prototype.PrototypeInheritance;
using DesignPatterns.Prototype.PrototypeInheritanceEasy;
using DesignPatterns.SOLID.DIP;
using DesignPatterns.SOLID.LP;
using DesignPatterns.SOLID.OCP;
using DesignPatterns.SOLID.SRP;
using System;
using System.Diagnostics;

//Console.WriteLine("Hello, World!");


//SOLID SRP - single responsibility principle
//SRPMain.Main();

//SOLID OCP - open closed principle
//OCPMain.Main();

//SOLID LP - Liskov principle
//LPMain.Main();

//SOLID DIP - Dependency Inversion principle
//DIPMain.Main();

//Builder - Fluent Builder
//BuilderMain.Main();

//Builder - Inheritance builder
//BuilderInheritanceMain.Main();

//Builder - Stepwise builder
//StepwiseBuilderMain.Main();

//Builder - Functional builder
//FunctionalBuilder.Main();

//Builder - Facets builder
//FactetdBuilderMain.Main();

//Factory - PointExample
//PointExampleMain.Main();

//Factory - ObjectTrackingAndBulkReplacement
//ObjectTrackingAndBulkReplacementMain.Main();

//Factory - ObjectTrackingAndBulkReplacement
//AbstractFactoryMain.Main();

//Prototype - ICloneableIsBad
//ICloneableIsBadMain.Main();

//Prototype - ICloneableIsBad
//CopyConstructorsMain.Main();

//Prototype - PrototypeInheritanceEasyMain
//PrototypeInheritanceEasyMain.Main();

//Prototype - PrototypeInheritance
//PrototypeInheritanceMain.Main();

//Prototype - CopyThroughSerialization
//CopyThroughSerializationMain.Main();

//CompositeCommandMain.Main();

//EventBrokerMain.Main();

//MedtiatRMain.Main();


void pyramid(int n)
{
    var colN = 2 * n - 1;

    for (int i = 0; i < n; i++)
	{
        var stair = "";
		for (int j = 0; j < colN; j++)
		{
            
            if (j < (colN - 1) / 2 - i)
            {
                stair += ' ';
            }
            else if (j > (colN - 1) / 2 + i)
            {
                stair += ' ';
            }
            else
            {
                stair += '#';
            }
        }
        Console.WriteLine(stair);
	}

}

pyramid(4);