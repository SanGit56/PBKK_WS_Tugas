<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

        <title><?= NAMA_SITUS . ": " . ucfirst(service('request')->uri->getSegment(1)) . " - " . ucfirst(service('request')->uri->getSegment(2)) ?></title>

        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/style.min.css" rel="stylesheet" />
        <link href="<?= base_url('css/styles.css') ?>" rel="stylesheet" />
        <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <?php include('_bagian/navbar.php'); ?>

        <div id="layoutSidenav">
            <?php include('_bagian/sidebar.php'); ?>
            
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Buku</h1>
                        
                        <ol class="breadcrumb">
                            <?php
                                $segments = service('request')->uri->getSegments();
                                $uriString = service('request')->uri->getPath();

                                foreach ($segments as $segment):
                                    $url = substr($uriString, 0, strpos($uriString, $segment)) . $segment;
                                    $is_active = $url == $uriString;
                                ?>

                                <li class="breadcrumb-item <?php echo $is_active ? 'active' : '' ?>">
                                    <?php if ($is_active): ?>
                                        <?php echo ucfirst($segment) ?>
                                    <?php else: ?>
                                        <a href="<?php echo site_url($url) ?>"><?php echo ucfirst($segment) ?></a>
                                    <?php endif; ?>
                                </li>

                                <?php endforeach;
                            ?>
                        </ol>

                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                Data Buku
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th>id</th>
                                            <th>judul</th>
                                            <th>sinopsis</th>
                                            <th>harga</th>
                                            <th>jumlah_stok</th>
                                            <th>entri_tgl</th>
                                            <th>aksi</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>id</th>
                                            <th>judul</th>
                                            <th>sinopsis</th>
                                            <th>harga</th>
                                            <th>jumlah_stok</th>
                                            <th>entri_tgl</th>
                                            <th>aksi</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                        <?php
                                        $arr_judul = ['Petualangan Si Kancil yang Bijak',
                                        'Misteri Pulau Natuna',
                                        'Serangan Monster Guntur',
                                        'Rahasia Labirin Terlarang',
                                        'Pencarian Permata Biru',
                                        'Pahlawan dari Dunia Lain',
                                        'Kisah Sang Pemimpi',
                                        'Serangan disaat Fajar',
                                        'Pertarungan Pahlawan Cahaya',
                                        'Sesuatu yang Tertinggal di Hutan',
                                        'Petualangan Naga Ajaib',
                                        'Tragedi Kota Abandon',
                                        'Rahasia Pulau Terpencil',
                                        'Gelombang Massa di Pantai',
                                        'Misteri Buku Merah'];
                                        $arr_sinop = ['Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
                                        'Quisque bibendum justo eget magna posuere, non tincidunt nisi convallis.',
                                        'Sed ac sapien vel odio vestibulum tincidunt.',
                                        'Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.',
                                        'Ut vel velit vel metus finibus eleifend.',
                                        'Proin euismod odio ac magna varius, non consequat velit suscipit.',
                                        'Vestibulum bibendum turpis in ante aliquet, in posuere mi feugiat.',
                                        'Fusce vitae augue nec ligula auctor ultricies.',
                                        'Nullam non libero a turpis feugiat hendrerit.',
                                        'Maecenas accumsan orci ut cursus fringilla.',
                                        'Donec eu tortor quis velit cursus suscipit ac ac ipsum.',
                                        'Aenean hendrerit turpis at neque euismod, eu accumsan felis imperdiet.',
                                        'Cras a quam id arcu pellentesque tempus in non est.',
                                        'Integer lacinia ligula eu velit dictum, a ullamcorper odio volutpat.',
                                        'Praesent eu nisl eget lacus luctus facilisis.'];
                                        $arr_harga = [29990, 49990, 39990, 59990, 19990,
                                        79990, 34990, 69990, 24990, 89990,
                                        44990, 54990, 74990, 64990, 14990];
                                        $arr_jml = [10, 5, 8, 12, 20, 15, 18, 25, 30, 22, 40, 35, 28, 16, 45];

                                        for ($i = 0;$i <= 14;$i++)
                                        {
                                            $j = $i + 1;
                                            echo '<tr>
                                                <td>' . $j . '</td>
                                                <td>' . $arr_judul[$i] . '</td>
                                                <td>' . $arr_sinop[$i] . '</td>
                                                <td>' . $arr_harga[$i] . '</td>
                                                <td>' . $arr_jml[$i] . '</td>
                                                <td>
                                                    <div class="btn-group">
                                                        <a href="#" class="btn btn-warning">
                                                            <i class="fas fa-edit"></i>Ubah
                                                        </a>
                                                        <a href="#" class="btn btn-danger">
                                                            <i class="fas fa-trash-alt"></i>Hapus
                                                        </a>
                                                    </div>
                                                </td>
                                                <td>' . date("Y-m-d H:i:s") . '</td>
                                            </tr>';
                                        }
                                        ?>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </main>

                <?php include('_bagian/footer.php'); ?>
                
            </div>
        </div>
        <a class="scroll-to-top rounded" href="#page-top">
            <i class="fas fa-angle-up"></i>
        </a>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('js/scripts.js') ?>"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('assets/demo/chart-area-demo.js') ?>"></script>
        <script src="<?= base_url('assets/demo/chart-bar-demo.js') ?>"></script>
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/umd/simple-datatables.min.js" crossorigin="anonymous"></script>
        <script src="<?= base_url('js/datatables-simple-demo.js') ?>"></script>
    </body>
</html>
