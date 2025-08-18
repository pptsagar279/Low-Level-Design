package org.example.model;

public class Room {
    private int roomId;
    private Status status;
    private RoomType roomType;
    private double roomPrice;

    public Room(int roomId, Status status, RoomType roomType, double roomPrice)
    {
        this.roomId = roomId;
        this.status = status;
        this.roomType = roomType;
        this.roomPrice = roomPrice;
    }

    public int getRoomId()
    {
        return roomId;
    }

    public Status getStatus()
    {
        return status;
    }
    public double getPrice()
    {
        return roomPrice;
    }

    public RoomType getRoomType()
    {
        return roomType;
    }
}
