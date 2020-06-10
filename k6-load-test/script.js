import { sleep } from "k6";
import http from "k6/http";

export let options = {
    // Add VU ramping option, total test length is 3m
    stages: [
        // Ramp up from 1 VU to 25 VUs for 1 minute
        { target: 25, duration: "60s" },

        // Stay constant at 25 VUs for 1 minute
        { target: 25, duration: "60s" },

        // Ramp down from 25 VUs to 0 VUs for 1 minute
        { target: 0, duration: "60s" }
    ]
};

export default function() {
  http.get("https://test.loadimpact.com/");
  sleep(3);
}