package com.example.dep;

import org.springframework.stereotype.Component;

@Component
public class fishingService {
    public String GetFish(String n)
    {
        return "You have " + n + " fishes";
    }
}
