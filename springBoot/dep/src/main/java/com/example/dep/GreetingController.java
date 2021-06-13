package com.example.dep;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GreetingController {

    fishingService _fs;

    public GreetingController(fishingService fs ) {
        super();
        this._fs = fs;
    }
    @GetMapping("/")
    public String SayHello() {
        return "Hello Mandy!"  +_fs.GetFish("six");
    }
}
