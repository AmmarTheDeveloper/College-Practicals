def hill_climbing(f, x0):
    x = x0
    step = 0.1  # step size
    while True:
        # Try moving left and right
        neighbors = [x - step, x + step]
        # Pick the better one
        best = max(neighbors, key=f)
        if f(best) <= f(x):  # no improvement
            return x
        x = best  # move to better neighbor

print("Suraj Kanojiya 318")

# Function to maximize
def f(x):
    return -x**2 + 4*x + 10

# Start from x=0
best_x = hill_climbing(f, 0)
print("Best solution:", best_x)
print("Maximum value:", f(best_x))
