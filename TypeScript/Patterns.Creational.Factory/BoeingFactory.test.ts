/* Factory pattern
 * BoeingFactory that takes types of plan e.g. 737, 747, 787, etc
 * and returns the corresponding plane object
*/

import Boeing737_Max10 from './Boeing737';
import Boeing747_8I from './Boeing747';
import Boeing767_300ER from './Boeing767';
import Boeing777X from './Boeing777';
import Boeing787_10 from './Boeing787';
import BoeingAircraftTypes from './BoeingAircraftTypes';
import BoeingFactory from './BoeingFactory';

describe('BoeingFactory', () => {
  test.each([
    { aircraftName: 'B737 Max10', aircraftType: BoeingAircraftTypes.B737_Max10, aircraft: Boeing737_Max10 },
    { aircraftName: 'B747 8I', aircraftType: BoeingAircraftTypes.B747_8I, aircraft: Boeing747_8I },
    { aircraftName: 'B767-300ER', aircraftType: BoeingAircraftTypes.B767_300ER, aircraft: Boeing767_300ER },
    { aircraftName: 'B777X', aircraftType: BoeingAircraftTypes.B777X, aircraft: Boeing777X },
    { aircraftName: 'B787-10', aircraftType: BoeingAircraftTypes.B787_10, aircraft: Boeing787_10 }
  ])('$aircraftName type, returns $aircraftName aircraft',
    ({ aircraftType, aircraft }) => {
      let factory = new BoeingFactory();

      let plane = factory.CreateAircraft(aircraftType);

      expect(plane).toBeInstanceOf(aircraft); 
    });
})