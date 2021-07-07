/* Abstract factory pattern
 * Aircraft factory - an abstract factory that creates abstract Aircraft objects via CreateAircraft() method
 * Boeing factory - a concrete factory implementing AircraftFactory that returns Boeing aircraft (subclasses of Aircraft)
 * Airbus factory - a concrete factory implementing AircraftFactory that returns Airbus aircraft (subclasses of Aircraft)
*/

import AirbusFactory from "./AirbusFactory";
import Airbus_A380 from "./Airbus_A380";
import Aircraft from "./Aircraft";
import Boeing787_10 from "./Boeing787_10";
import BoeingFactory from "./BoeingFactory";


describe('AbstractFactory', () => {
  test('BoeingFactory returns Aircraft type', () => {
    let boeingFactory = new BoeingFactory();

    let aircraft = boeingFactory.CreateAircraft(0); 
    expect(aircraft).toBeInstanceOf(Aircraft);
  }); 

  test('BoeingFactory returns aircraft with specified number of seats', () => {
    let boeingFactory = new BoeingFactory();
    const expectedSeats = 99;
    let aircraft = boeingFactory.CreateAircraft(expectedSeats); 
    expect(aircraft.numberOfSeats).toEqual(expectedSeats);
  }); 

  test('BoeingFactory returns Boeing 737-10', () => {
    let boeingFactory = new BoeingFactory();

    let aircraft = boeingFactory.CreateAircraft(0); 
    
    expect(aircraft).toBeInstanceOf(Boeing787_10);
  }); 

    test('Boeing 737-10 has correct manufacturer info', () => {
    let boeingFactory = new BoeingFactory();

    let aircraft = boeingFactory.CreateAircraft(0); 
    
    expect(aircraft.DisplayManufacturerInformation()).toEqual('Boeing - 787-10'); 
  }); 

  test('AirbusFactory returns Aircraft type', () => {
    let factory = new AirbusFactory();

    let aircraft = factory.CreateAircraft(0); 
    expect(aircraft).toBeInstanceOf(Aircraft);
  }); 

  test('AirbusFactory returns Airbus_A380', () => {
    let factory = new AirbusFactory();

    let aircraft = factory.CreateAircraft(0); 
    expect(aircraft).toBeInstanceOf(Airbus_A380);
  }); 

  test('AirbusFactory returns Airbus_A380 with specified number of seats', () => {
    let factory = new AirbusFactory();
    const expectedSeats = 300;

    let aircraft = factory.CreateAircraft(expectedSeats); 

    expect(aircraft.numberOfSeats).toEqual(expectedSeats);
  }); 

  test('Boeing 737-10 has correct manufacturer info', () => {
    let factory = new AirbusFactory();

    let aircraft = factory.CreateAircraft(0); 
    
    expect(aircraft.DisplayManufacturerInformation()).toEqual('Airbus - A380');  
  }); 
});  