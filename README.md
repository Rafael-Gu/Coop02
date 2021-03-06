## 软件工程第5次作业（结对编程2）

----

### 四则运算的生成

#### TODO LIST

+ 核心算理库
  + [x] 表达式的表示
      + [x] 二叉树
      + [x] 字符串
      + [x] 转化关系
  + [ ] 表达式的生成
    + [ ] 除以0处理
    + [ ] 不允许负数（以及负表达式）
    + [ ] 不允许小数（以及非整数表达式）
    + [ ] 括号约束（）
      + [ ] 强制无括号
      + [ ] 括号的转化
  + [ ] 优化项（非必要）
    + [ ] 避免重复题目（当题目数量很大而允许的算值范围很小时无法实现）
    + [ ] 结构优化
    + [ ] 效能优化
  + [ ] 算理库测试
    + [x] 字符串表达的正确性
    + [x] 表达式的运算良好性
    + [ ] 表达式是否符合用户约束要求
    + [ ] 其他单元测试内容
+ 生成器图形用户界面
  + [x] 图形界面设计
  + [ ] 控件之间的制约关系（Enable）
  + [ ] 向文件写入结果
  + [ ] 向文件写入
    + [ ] 题目
    + [ ] 答案
  + [ ] 控件的动作行为（事件订阅）
  + [ ] 预留……（其他附加考虑项）



## 现存问题

1. 如何保证强制生成**无需括号**的表达式

   表达式以一个树的形式呈现，这些表达式最终转化成字符串的时候需要适当的符号处理，需要考虑运算符的优先级来决定括号。

   可能方案：定义运算优先级表（需要对某些类重构）

2. 除法式的结果

   基于四则运算的代数特性，**除法**是这四种算符中相对特殊的一个，首先，它的**右算元不接受0**（*除0错误*），其次，它**不**满足**结合律**，第三个，除法对于整数集**不封闭**，其结果有可能是小数，事实上，整数集上的除法结果将落到有理数集上，有理数集合除了整数以外还包含**有限小数**和**无限循环小数**，当结果为无限循环小数时该如何表示。

   可能方案：

   1. 规避无限循环小数的产生（较困难，需要数论知识，如质因数规则）
   2. 无限循环小数以分数形式呈现
      + 分数表示格式
      + 如何判断结果有必要使用一个分数表示（判断一个除式结果是一个无限循环小数，即除不尽）
   3. 由用户决定以何种形式实现
      + 如果要求用**分数**时，整数结果不变，有限小数和无限循环小数以**约化的分数**形式出现（需要公因数算法）
      + 如果要求用**小数**时，用户必须提供小数的精确位数，除式通过机器计算得出浮点数结果，然后根据精确位数进行必要的舍入。

3. 预留……