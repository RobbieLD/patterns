abstract class Aircraft {
    constructor(public numberOfSeats: number){

    }

    public abstract DisplayManufacturerInformation(): string;
}

export default Aircraft;