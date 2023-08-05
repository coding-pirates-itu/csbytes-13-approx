// Least square method
// y = ax + b
// a = (mean(x) * mean(y) - mean(x * y)) / (mean(x) ^ 2 - mean(x ^ 2))
// b = mean(y) - a * mean(x)

var points = new[]
{
    new[] {-1.0, -3.0},
    new[] {0.0, 0.8},
    new[] {1.0, 3.1}
};

var n = points.Length;
var sx = points.Select(p => p[0]).Sum();
var sy = points.Select(p => p[1]).Sum();
var sxy = points.Select(p => p[0] * p[1]).Sum();
var sx2 = points.Select(p => p[0] * p[0]).Sum();
var sy2 = points.Select(p => p[1] * p[1]).Sum();

var a = (sx * sy - n * sxy) / (sx * sx - n * sx2);
var b = sy - a * sx;
var t = n * sxy - sx * sy;
var r2 = t * t / (sx * sx - n * sx2) / (sy * sy - n * sy2);

Console.WriteLine($"y = {(float)a}x + {(float)b} with R2 = {r2}");

foreach (var p in points)
{
    Console.WriteLine($"\tx = {p[0]}\ty' = {(float)(a * p[0] + b)}\ty = {p[1]}");
}
