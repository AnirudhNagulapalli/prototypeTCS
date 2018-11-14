export interface Employee{
    id: string;
    pickup_datetime: string;
    dropoff_datetime: string;
    passenger_count: string;
    pickup_longitude: DoubleRange;
    pickup_latitude: DoubleRange;
    dropoff_longitude: DoubleRange;
    dropoff_latitude: DoubleRange;
    trip_duration: Int16Array;
}