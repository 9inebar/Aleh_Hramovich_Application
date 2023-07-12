// See https://aka.ms/new-console-template for more information

using Decorator;

IGigantosaurus igigantosaurus = new LoudGigantosaurusDecorator(new ExtraLoudGigantosaurusDecorator(new Gigantosaurus()));
igigantosaurus.Roar();