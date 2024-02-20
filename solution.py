```python
def excel_col_to_num(col):
    result = 0
    for i in range(len(col)):
        result *= 26
        result += ord(col[i]) - 64
    return result
```