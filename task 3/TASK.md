# Task 3: LCM Web Method

## Requirements

Implement a web method accessible via HTTP GET that:
1. Accepts two natural numbers: `x` and `y` (as query parameters)
2. Returns their Lowest Common Multiple (LCM)
3. Returns plain text containing only digits - NOT HTML or JSON
4. If either x or y is not a natural number (positive integer > 0), return "NaN"

## Technical Specifications

- **Method**: HTTP GET
- **Input**: Query parameters `x` and `y`
- **Output**: Plain text string (text/plain content type)
- **Valid input**: Natural numbers (positive integers: 1, 2, 3, ...)
- **Invalid cases**: Zero, negative numbers, non-integers, missing parameters → return "NaN"

## URL Format

The endpoint must be accessible at a URL ending with your email address where:
- All characters except English letters and digits are replaced with underscores
- Example: `p.lebedev@itransition.com` → `p_lebedev_itransition_com`

Final URL format: `http://host:port/path/{email_formatted}?x={}&y={}`

## LCM Calculation

LCM (Lowest Common Multiple) can be calculated using:
- Formula: `LCM(x, y) = (x * y) / GCD(x, y)`
- GCD = Greatest Common Divisor (use Euclidean algorithm)

## Examples

- `?x=12&y=18` → returns `36`
- `?x=5&y=7` → returns `35`
- `?x=0&y=10` → returns `NaN` (0 is not natural)
- `?x=-5&y=10` → returns `NaN` (negative)
- `?x=abc&y=10` → returns `NaN` (not a number)

## Submission Format

```
!task3 {your_email} http://yourhost.com/path/{email_formatted}?x={}&y={}
```
