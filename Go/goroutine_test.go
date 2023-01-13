package main

import (
	"fmt"
	"testing"
	"time"
)

func DoSomehting(iteration int) {
	fmt.Printf("hello iteration %d", iteration)
}

func TestDoSomething(t *testing.T) {
	for i := 0; i < 50; i++ {
		go DoSomehting(i)
	}

	time.Sleep(2 * time.Second)
}
