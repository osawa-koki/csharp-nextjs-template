# csharp-nextjs-template

C#とNext.jsで構築する簡単なテンプレートプロジェクト。  

## 実行方法

```shell
# Dockerfileのビルドの実行
docker build -t csharp-nextjs-template .
docker run -p 80:80 -it --rm --name my-csharp-nextjs-template csharp-nextjs-template

# 一行で書くと、、、
docker build -t csharp-nextjs-template . && docker run -p 80:80 -it --rm --name my-csharp-nextjs-template csharp-nextjs-template
```
