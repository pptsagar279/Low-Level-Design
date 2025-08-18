package org.example.model;

import java.time.LocalDateTime;
import java.util.UUID;

public class Reservation {
    private int reservationId;
    private int roomId;
    private LocalDateTime startDate;
    private LocalDateTime endDate;
    private int numberOfGuests;

    public Reservation(int reservationId, int roomId, LocalDateTime startDate, LocalDateTime endDate, int numberOfGuests)
    {
        this.reservationId = UUID.randomUUID().toString().hashCode();
        this.roomId = roomId;
        this.startDate = startDate;
        this.endDate = endDate;
        this.numberOfGuests = numberOfGuests;
    }
}
