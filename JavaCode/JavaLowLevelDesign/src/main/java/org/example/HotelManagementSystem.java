package org.example;

import org.example.model.*;

import java.time.LocalDateTime;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.ConcurrentHashMap;

public class HotelManagementSystem {
    private Map<Integer,Room> rooms;
    private Map<String,Reservation> reservations;
    private Map<String, Guest> guests;
    private HotelManagementSystem()
    {
        rooms = new ConcurrentHashMap<>();
        reservations = new ConcurrentHashMap<>();
        guests = new ConcurrentHashMap<>();
    }

    private static class HotelManagementSystemHelper
    {
        private static final HotelManagementSystem instance = new HotelManagementSystem();
    }

    public static HotelManagementSystem getInstance()
    {
        return HotelManagementSystemHelper.instance;
    }
    public synchronized void AddRoom(RoomType roomType, double price)
    {
        var room = new Room(UUID.randomUUID().toString().hashCode(), Status.AVAILABLE, roomType, price);
    }
    public synchronized void reserveRoom(int roomId, LocalDateTime startDate, LocalDateTime endDate)
    {
        var room = rooms.get(roomId);
        if(room != null && room.getStatus() == Status.AVAILABLE && )
        {

        }
    }

    public void checkIn()
    {

    }

    public void checkOut()
    {

    }
}
