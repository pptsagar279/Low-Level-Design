package org.example.model;

import java.util.UUID;

public class Guest {
    private long id;
    private String name;
    private String address;
    private String email;
    private String phoneNumber;

    public Guest(String name, String address, String email, String phoneNumber)
    {
        this.id = UUID.randomUUID().toString().hashCode();
        this.name = name;
        this.address = address;
        this.email = email;
        this.phoneNumber = phoneNumber;
    }

    public long getId()
    {
        return id;
    }

    public String getName()
    {
        return name;
    }

    public String getAddress()
    {
        return address;
    }

    public String getEmail()
    {
        return email;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }
}
