import Link from 'next/link';
import Layout from '../components/Layout';

const IndexPage = () => (
  <Layout>
    <h1>Hello "csharp-nextjs-template" 👋</h1>
    <p>
      <Link href="/about">About</Link>
    </p>
  </Layout>
);

export default IndexPage;
